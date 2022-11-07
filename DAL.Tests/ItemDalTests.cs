using AutoMapper;
using TradingCompany.DAL;
using NUnit.Framework;
using System;
using System.Linq;
using DAL.Concrete;
using DAL.Interfaces;

namespace DAL.Tests
{
    [TestFixture]
    public class ItemDalTests
    {
        private IMapper _mapper;
        private IItemDal _dal;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            MapperConfiguration conf = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(ItemDal).Assembly)
                );
            _mapper = conf.CreateMapper();

            _dal = new ItemDal(_mapper);
        }


        //[OneTimeTearDown]
        //public void Tear
        //private void InsertTestGenre()
        //{
        //    throw new NotImplementedException();
        //}

        [Test]
        public void CanReadFromDB()
        {
            var itemDal = new ItemDal(_mapper);

            var items = itemDal.GetAllItems();

            Assert.IsNotNull(items);
            Assert.Contains("Laptop", items.Select(g => g.Name).ToList());
        }




    }
}
