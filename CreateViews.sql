
--MostAbsent
/*select top 5 [CRONUS Sverige AB$Employee].[First Name] 
                    from dbo.[CRONUS Sverige AB$Employee Absence] 
                    inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_ 
                    group by [CRONUS Sverige AB$Employee].[First Name] 
                    order by COUNT(*) desc*/

--Employees Sick 2004
					
				--	create view EMPLOYEES_SICK_2004 as
					select [CRONUS Sverige AB$Employee].[First Name],  [CRONUS Sverige AB$Employee].[Job Title], [From Date], [To Date], [Cause of Absence Code] 
                    from dbo.[CRONUS Sverige AB$Employee Absence] 
                    inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_ 
                    where [Cause of Absence Code] = 'SJUK' 
                    and[From Date] >= '2004-01-01 00:00:00' 
                    and[From Date] < '2005-01-01 00:00:00';

					
--Employees & Relatives
--create view EMPLOYEES_AND_RELATIVES as
/*select[CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name], [CRONUS Sverige AB$Employee].[Job Title], [CRONUS Sverige AB$Employee Relative].[First Name] Relative, [CRONUS Sverige AB$Relative].Description 
                    from(([CRONUS Sverige AB$Employee Relative]
                    inner join [CRONUS Sverige AB$Employee] on[CRONUS Sverige AB$Employee Relative].[Employee No_]= [CRONUS Sverige AB$Employee].No_)
                    inner join[CRONUS Sverige AB$Relative] on[CRONUS Sverige AB$Employee Relative].[Relative Code] = [CRONUS Sverige AB$Relative].Code)*/