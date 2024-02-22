// See https://aka.ms/new-console-template for more information
using RealLifeInandAbs.Abstract;
using RealLifeInandAbs.Adapters;
using RealLifeInandAbs.Concrete;
using RealLifeInandAbs.Entites;



BaseCustomerManager customerManager = new StarbucksCustumerManager(new MernisSeviceAdapter());
customerManager.Save(new Customer { DateofBirth = 1996, FirstName = "Emre", LastName = "Dağlar", NationalIdentity = 122 });

