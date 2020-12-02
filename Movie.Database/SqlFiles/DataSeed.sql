
INSERT INTO Users(Username,Password)
VALUES('user1','12345')

INSERT INTO Users(Username,Password)
VALUES('user2','12345')

INSERT INTO Users(Username,Password)
VALUES('user3','12345')

DECLARE @USER1_ID INT = (SELECT ID FROM Users WHERE Username = 'user1')
DECLARE @USER2_ID INT = (SELECT ID FROM Users WHERE Username = 'user2')
DECLARE @USER3_ID INT = (SELECT ID FROM Users WHERE Username = 'user3')


INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie1',2007,75,'comedy-horror')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie2',2008, 67, 'comedy-drama')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie3',2015, 89, 'action-mystery')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie4',2016, 115,'western-action')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie5',2017, 105,'fantasy-comedy')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie6',2013, 123,'fantasy-drama')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie7',2019, 120,'comedy-drama')

INSERT INTO Movies (Title, YearOfRelease, RunningTime, Genres) 
VALUES('Movie8',2014, 90,'western-action')



DECLARE @MOVIE1_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie1')
DECLARE @MOVIE2_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie2')
DECLARE @MOVIE3_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie3')
DECLARE @MOVIE4_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie4')
DECLARE @MOVIE5_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie5')
DECLARE @MOVIE6_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie6')
DECLARE @MOVIE7_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie7')
DECLARE @MOVIE8_ID INT = (SELECT ID FROM Movies WHERE title = 'Movie8')

INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE1_ID, @USER1_ID, 1)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE2_ID, @USER1_ID, 3)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE3_ID, @USER1_ID, 4)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE4_ID, @USER1_ID, 5)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE5_ID, @USER1_ID, 3)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE6_ID, @USER1_ID, 2)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE7_ID, @USER1_ID, 1)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE8_ID, @USER1_ID, 3)

INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE1_ID, @USER2_ID, 3)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE2_ID, @USER2_ID, 2)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE3_ID, @USER2_ID, 1)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE4_ID, @USER2_ID, 5)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE5_ID, @USER2_ID, 2)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE6_ID, @USER2_ID, 2)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE7_ID, @USER2_ID, 4)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE8_ID, @USER2_ID, 5)


INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE1_ID, @USER3_ID, 4)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE2_ID, @USER3_ID, 5)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE3_ID, @USER3_ID, 5)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE4_ID, @USER3_ID, 5)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE5_ID, @USER3_ID, 3)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE6_ID, @USER3_ID, 2)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE7_ID, @USER3_ID, 1)
INSERT INTO MovieRates (MovieID, UserID, UserRate) VALUES(@MOVIE8_ID, @USER3_ID, 1)

