using AutoMapper;
using TradingCompany.DAL;
using NUnit.Framework;
using System;
using System.Linq;
using DAL.Concrete;
using DAL.Interfaces;
using TradingCompany.DTO;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;

namespace DAL.Tests
{
    [TestFixture]
    public class ItemDalTests
    {
        private IMapper _mapper;
        private IItemDal _itemDal;
        private ItemDto _testItem;
        private ItemDto _createdItem;


        [OneTimeSetUp]
        public void SetupOnce()
        {
            MapperConfiguration conf = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(ItemDal).Assembly)
                );
            _mapper = conf.CreateMapper();
            _itemDal = new ItemDal(_mapper);
        }

        [SetUp]
        public void SetUp()
        {
            InsertTestItem();
        }


        [TearDown]
        public void TearDown()
        {
            DeleteTestItem();
            DeleteCreatedItem();
        }

        private void InsertTestItem()
        {
            ItemDto item = new ItemDto();
            item.Name = "testItem";
            item.SellerID = 1;
            item.Price = 1234;
            item.RowInsertTime = DateTime.Now;
            using (var entities = new TradingCompanyEntities())
            {
                var ItemInDb = _mapper.Map<Item>(item);
                ItemInDb.RowUpdateTime = DateTime.Now;
                ItemInDb.Availability = true;

                entities.Items.Add(ItemInDb);
                entities.SaveChanges();
                _testItem = _mapper.Map<ItemDto>(ItemInDb);
            }
        }
        private void DeleteCreatedItem()
        {
            if (_createdItem != null)
            {
                using (var entities = new TradingCompanyEntities())
                {
                    var rolef = entities.Items.SingleOrDefault(x => x.ItemID == _createdItem.ItemID);
                    if (rolef != null)
                    {
                        entities.Items.Remove(rolef);
                        entities.SaveChanges();
                    }
                }
            }
        }

        private void DeleteTestItem()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var rolef = entities.Items.SingleOrDefault(x => x.ItemID == _testItem.ItemID);
                if (rolef != null)
                {
                    entities.Items.Remove(rolef);
                    entities.SaveChanges();
                }
            }
        }

        [Test]
        public void CanReadItemFromDb()
        {
            var Items = _itemDal.GetAllItems();
            var ItemId = _itemDal.GetItem(_testItem.ItemID);

            Assert.IsNotNull(Items);
            Assert.Contains(_testItem.Name, Items.Select(r => r.Name).ToList());
            Assert.IsNotNull(ItemId);
            Assert.AreEqual(_testItem.Name, ItemId.Name);
        }

        [Test]
        public void CanAddItemToDb()
        {
            ItemDto item = new ItemDto();
            item.Name = "newTestItem";
            item.SellerID = 1;
            item.Price = 1234;
            item.RowInsertTime = DateTime.Now;

            _createdItem = _itemDal.CreateItem(item);

            var items = new List<ItemDto>();
            using (var entities = new TradingCompanyEntities())
            {
                var itemsInDb = entities.Items.ToList();
                items = _mapper.Map<List<ItemDto>>(itemsInDb);
                Assert.IsNotNull(_createdItem);
                Assert.Contains(item.Name, items.Select(r => r.Name).ToList());
            }
        }

        [Test]
        public void CanUpdateItemInDb()
        {
            _testItem.Name = "updTestItem";
            _itemDal.UpdateItem(_testItem);
            using (var entities = new TradingCompanyEntities())
            {
                var itemInDb = entities.Items.SingleOrDefault(x => x.ItemID == _testItem.ItemID);
                var item = _mapper.Map<ItemDto>(itemInDb);
                Assert.AreEqual(_testItem.Name, item.Name);
            }
        }

        [Test]
        public void CanDeleteItemFromDb()
        {
            _itemDal.DeleteItem(_testItem.ItemID);
            using (var entities = new TradingCompanyEntities())
            {
                var itemsInDb = entities.Items.ToList();
                var items = _mapper.Map<List<ItemDto>>(itemsInDb);
                CollectionAssert.DoesNotContain(items.Select(r => r.ItemID).ToList(), _testItem.ItemID);
            }

        }
    }
}
