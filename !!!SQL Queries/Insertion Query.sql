Use Unit18GC

--Assessor

Insert into Assessor Values ('PH','Pol Hill', 'Bakery House, Bude, Cornwall', 'CV4 9DA', '07743070505', 'Pollhill5@gmail.com'); 

Insert into Assessor Values ('AS','Amy Snrook', '22 Maryvile Drive, Alridge, West Midlands', 'WS3 1K5', '07720156999', 'SnrookA@Yahoo.com'); 

Insert into Assessor Values ('SA','Sid Armage', '66 Gladesmore Drive, Stamford Hill, London', 'SW15 4AA', '01217781124', 'Sid0@gmaill.com'); 

Insert into Assessor Values ('SQ','Sonia Quilt', '77 Beacham Drive, Royal Leamnington Spa, Warwickshire', 'CV9 3AB', '07762287713', 'SoniaQuilt@yahoo.com'); 

Insert into Assessor Values ('AB','Ania Bosow', 'Grove Lane Cottage, Pelsall, West Midlands', 'WS4 2AW', '07702558994', 'ABosow599@gmail.com'); 

Insert into Assessor Values ('AZ','Anneke Zolz', '22 Hollywood Lane, Hollywood, Hendsford, Birmingham', 'B2 RJ2', '07750066605', 'AnnekeandTodZolz@talk.com'); 


-- Course

Insert into Course Values ('102-First Aid', 'First Aid', '95', '1 day')

Insert into Course Values ('103-Food Safety', 'Food Safety', '55', '4 hours')

Insert into Course Values ('104-Health and Safety', 'Health and Safety', '170', '2 days')

Insert into Course Values ('105-Fire Safety', 'Fire Safety', '55', '4 hours')

Insert into Course Values ('106-Manual Handling', 'Manual Handling', '95', '1 day')

 Insert into Course Values ('107-People Handling', 'People Handling', '95', '1 day')


 -- Venue

 Insert into Venue Values ('TMC', 'The Mountsorrel Centre', 'Alridge, West Midlands', 'WS6 2JS', '07750066605', 'Ammo Betty', 'admin@themountsorrelcentre', '250', 'https://www.google.com/maps/place/The+Great+Pyramid+of+Giza/@29.9792345,31.130082,17z/data=!4m10!1m2!2m1!1spyramid+of+giza!3m6!1s0x14584587ac8f291b:0x810c2f3fa2a52424!8m2!3d29.9792345!4d31.1342019!15sCg9weXJhbWlkIG9mIGdpemFaESIPcHlyYW1pZCBvZiBnaXphkgERY3VsdHVyYWxfbGFuZG1hcmvgAQA!16zL20vMDM2bWs')

 Insert into Venue Values ('SPC', 'St Pat Centre', 'Bedworth, Cornwall', 'CV4 9DA', '07759832597', 'Joe Falsky', 'admin@spatcentre', '300', 'https://www.google.com/maps/place/Khon+Kaen,+Thailand/@16.3633347,101.346087,8z/data=!3m1!4b1!4m5!3m4!1s0x31226d6f3716ca83:0x10469cfc8de4a00!8m2!3d16.4420124!4d102.8361511')
 
 Insert into Venue Values ('SS', 'Solihull Suite', 'Manchester House, Manor Square, London', 'NW8 3QB', '07785364872', 'Paul Weale', 'admin@solihullsuite', '400', 'https://www.google.com/maps/place/Khartoum,+Sudan/@15.4722344,32.5768952,12z/data=!4m5!3m4!1s0x168e8fde9837cabf:0x191f55de7e67db40!8m2!3d15.5006642!4d32.5598931')
 
 Insert into Venue Values ('LCS', 'Lookley Community School', 'Shrubland Street, Royal Leamington Spa, Warwickshire', 'CV9 3AD', '07789547779', 'David Shullps', 'admin@lookleycommunityschool', '325', 'https://www.google.com/maps/place/Novo+Progresso,+State+of+Par%C3%A1,+68193-000,+Brazil/@-7.0402685,-55.4152492,6z/data=!4m5!3m4!1s0x92f884cacbe15e9d:0xf833f0c1952b314f!8m2!3d-7.0412788!4d-55.4197168')

 -- Student

 Insert into Student Values ('John Whitiker', 'Swansea, 22 Mush drive', 'FF1 CH2', 'j@whiticker.com', '0736763834', 'Needs help')

 Insert into Student Values ('Tyrone Bell', 'Swansea, 23 Mush Drive', 'FF1 CH3', 't@bell.com', '075234334', 'Lives in Mush')

 Insert into Student Values ('Danny Dergarndo', 'Brmingham, 76 Soldier76 street', 'TO0 0SA', 'priest@pockethealer.com', '073234134', 'Exceptional player')

 Insert into Student Values ('Feronce Twink', 'London, 360 noscope road', 'LL1 1RT', 'u@wish.com', '23423894432', 'Noice guy')

 Insert into Student Values ('Machima Hallando', 'Swansea, Mayhill', 'SA2 9HW', 'key@n.com', '0736233334', 'Cooks a good thai')

 -- Course Schedule

 Insert into CourseSchedule Values ('C1', '102-First Aid', 'AS', 'TMC', 1, 0, '12/19/2022')
 Insert into CourseSchedule Values ('C2', '102-First Aid', 'AS', 'TMC', 2,0 , '12/19/2022')
 Insert into CourseSchedule Values ('C3', '102-First Aid', 'AS', 'TMC', 3, 1, '12/19/2022')
  Insert into CourseSchedule Values('C4', '102-First Aid', 'AS', 'TMC', 5, 1, '10/19/2022')
 Insert into CourseSchedule Values ('C5', '103-Food Safety', 'PH', 'SPC', 2, 1, '05/09/2022')
 Insert into CourseSchedule Values ('C6', '103-Food Safety', 'PH', 'SPC', 4, 1, '05/09/2022')
  Insert into CourseSchedule Values('C7', '103-Food Safety', 'PH', 'SPC', 5, 0, '05/09/2022')
 Insert into CourseSchedule Values ('C8', '104-Health and Safety', 'AB', 'SS', 1, 0, '03/10/2022')
 Insert into CourseSchedule Values ('C9', '104-Health and Safety', 'AB', 'SS', 3, 0, '03/10/2022')
 Insert into CourseSchedule Values ('C10', '104-Health and Safety', 'AB', 'SS', 4, 0, '03/10/2022')
 Insert into CourseSchedule Values ('C11', '105-Fire Safety', 'AZ', 'LCS', 2, 1, '11/27/2022')
 Insert into CourseSchedule Values ('C12', '105-Fire Safety', 'AZ', 'LCS', 3, 1, '11/27/2022')
 Insert into CourseSchedule Values ('C13', '106-Manual Handling', 'SQ', 'TMC', 1, 0, '08/09/2022')
 Insert into CourseSchedule Values ('C14', '106-Manual Handling', 'SQ', 'TMC', 5, 1, '08/09/2022')
 Insert into CourseSchedule Values ('C15', '107-People Handling', 'AZ', 'SPC', 2, 0, '04/12/2022')
 Insert into CourseSchedule Values ('C16', '107-People Handling', 'AZ', 'SPC', 4, 0, '04/12/2022')




;