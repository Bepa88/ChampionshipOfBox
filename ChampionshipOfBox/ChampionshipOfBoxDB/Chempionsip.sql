CREATE VIEW [dbo].[Chempionsip]
	AS SELECT w.CountWinner as Ranking, s.Winner as Name,s.NumberOfBattle
FROM
(Select SUM(CountWinner) NumberOfBattle, Winner
from
(
(SELECT COUNT(*) CountWinner, Winner
  FROM Battle
 GROUP BY  Winner)
UNION ALL
(SELECT COUNT(*) CountLoser, Loser
  FROM Battle
 GROUP BY  Loser)) As Z
 GROUP BY Winner) as s
 JOIN
 (SELECT COUNT(*) CountWinner, Winner
  FROM Battle
 GROUP BY  Winner) as w
 ON s.Winner = w.Winner
