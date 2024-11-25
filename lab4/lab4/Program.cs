
using System;

Fleet fleet = new Fleet();

Sedan sedan1 = new Sedan { Model = "Toyota Camry", LicencePlate = "A123BC", TrunkCapacity = 500 };
Truck truck1 = new Truck { Model = "Ford F-150", LicencePlate = "D456EF", LoadCapacity = 2000 };

fleet.AddCar(sedan1);
fleet.AddCar(truck1);

Driver driver1 = new Driver { Name = "Иван Иванов", ExperienceYears = 5, MedicalCertificate = new MedicalCertificate { CertificateNumber = 1, IssueData = DateTime.Now, DoctorName = "Доктор Смит" } };
Driver driver2 = new Driver { Name = "Петр Петров", ExperienceYears = 10, MedicalCertificate = new MedicalCertificate { CertificateNumber = 2, IssueData = DateTime.Now, DoctorName = "Доктор Джонс" } };

fleet.RegisterDriver(driver1);
fleet.RegisterDriver(driver2);

DateTime specificDate = new DateTime(2023, 10, 5, 14, 30, 0);
DateTime specificDate2 = new DateTime(2020, 7, 3, 23, 0, 15);

fleet.CreateTrip(driver1, sedan1, specificDate, DateTime.Now.AddHours(-12), DateTime.Now);
fleet.CreateTrip(driver2, truck1, specificDate2, DateTime.Now.AddHours(-3), DateTime.Now);
 
fleet.DisplayTripsByDate();
