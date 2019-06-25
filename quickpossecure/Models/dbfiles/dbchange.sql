-- 12-12-2018
alter table Product add LowInventoryNotification float;
update Product set LowInventoryNotification = 5 where id>=0;


create table Notification(
	Id int NOT NULL PRIMARY KEY auto_increment,
	CreatedDate datetime,
    Text text,
    Title nvarchar(100),
    Type varchar(50)
);
﻿