# QuanLyThuVien
Project C#

## Author
#### [Nguyễn Văn Hiếu](https://www.facebook.com/hieunv1996)

#Tool
### VS 2015
### SQL Server 2012

# Setup in Windows
### Step 1: Run *script.sql* in SQL to built Database + data
### Step 2: Open project int VS and change value of *strcon* in DAL > SQLDataProvider
```cs
private static String strcon = "Data Source=(local);Initial Catalog=QLTV;Integrated Security=True";
```
### Step 3: Run & Relax
