using Observer;

var dataSource = new DataSource<int>();
var sheet1 = new SpreadSheet<int>(dataSource);
var sheet2 = new SpreadSheet<int>(dataSource);
var chart = new Chart<int>(dataSource);

dataSource.AddObserver(sheet1);
dataSource.AddObserver(sheet2);
dataSource.AddObserver(chart);

dataSource.Value = 1;
dataSource.Value = 2;

dataSource.RemoveObserver(sheet2);

dataSource.Value = 3;
