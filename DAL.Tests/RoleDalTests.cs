using AutoMapper;
using DAL.Concrete;
using DAL.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Tests
{
    [TestFixture]
    public class RoleDalTests
    {
        private IMapper _mapper;
        private IRoleDal _roleDal;
        private RoleDto _testRole;
        private RoleDto _createdRole;

        [OneTimeSetUp]
        public void SetUpOnce()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(RoleDal).Assembly));
            _mapper = config.CreateMapper();
            _roleDal = new RoleDal(_mapper);
        }

        [SetUp]
        public void SetUp()
        {
            InsertTestRole();
        }

        [TearDown]
        public void TearDown()
        {
            DeleteTestRole();
            DeleteCreatedRole();
        }

        private void DeleteTestRole()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var rolef = entities.Roles.SingleOrDefault(x => x.RoleID == _testRole.RoleID);
                if (rolef != null)
                {
                    entities.Roles.Remove(rolef);
                    entities.SaveChanges();
                }
            }
        }

        private void DeleteCreatedRole()
        {
            if (_createdRole!=null)
            {
                using (var entities = new TradingCompanyEntities())
                {
                    var rolef = entities.Roles.SingleOrDefault(x => x.RoleID == _createdRole.RoleID);
                    if (rolef != null)
                    {
                        entities.Roles.Remove(rolef);
                        entities.SaveChanges();
                    }
                }
            }
        }

        private void InsertTestRole()
        {
            RoleDto role = new RoleDto();
            role.Name = "TestRole";
            role.RowInsertTime = DateTime.UtcNow;
            using (var entities = new TradingCompanyEntities())
            {
                var roleInDB = _mapper.Map<Role>(role);
                entities.Roles.Add(roleInDB);
                entities.SaveChanges();
                _testRole = _mapper.Map<RoleDto>(roleInDB);
            }
        }

        [Test]
        public void CanReadFromDb()
        {
            var Roles = _roleDal.GetAllRoles();
            var RoleId= _roleDal.GetRoleById(_testRole.RoleID);


            Assert.IsNotNull(Roles);
            Assert.Contains(_testRole.Name, Roles.Select(r => r.Name).ToList());
            Assert.IsNotNull(RoleId);
            Assert.AreEqual(_testRole.Name, RoleId.Name);
        }

        [Test]
        public void CanAddToDb()
        {
            RoleDto newRole = new RoleDto();
            newRole.Name = "newtestRole";
            _createdRole = _roleDal.CreateRole(newRole);
            using (var entities = new TradingCompanyEntities())
            {
                var rolesInDB = entities.Roles.ToList();
                var roles = _mapper.Map<List<RoleDto>>(rolesInDB);
                Assert.IsNotNull(_createdRole);
                Assert.Contains(newRole.Name, roles.Select(r => r.Name).ToList());
            }

            
        }

        [Test]
        public void CanUpdateInDb()
        {
            _testRole.Name = "updTestRole";
            _roleDal.UpdateRole(_testRole);
            using (var entities = new TradingCompanyEntities())
            {
                var roleInDB = entities.Roles.SingleOrDefault(x => x.RoleID == _testRole.RoleID);
                var role = _mapper.Map<RoleDto>(roleInDB);
                Assert.AreEqual(_testRole.Name, role.Name);
            }
        }

        [Test]
        public void CanDeleteFromDb()
        {
            _roleDal.DeleteRole(_testRole.RoleID);
            using (var entities = new TradingCompanyEntities())
            {
                var rolesInDB = entities.Roles.ToList();
                var roles = _mapper.Map<List<RoleDto>>(rolesInDB);
                CollectionAssert.DoesNotContain(roles.Select(r => r.RoleID).ToList(), _testRole.RoleID);
            }

        }
    }
}
