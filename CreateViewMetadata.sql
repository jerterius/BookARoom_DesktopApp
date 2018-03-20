

select 'Employee' as Tabellnamn, [First Name], [Status], [Job Title], [Address] from dbo.[CRONUS Sverige AB$Employee] 
                    union 
                    select 'Employee Absence' as Tabellnamn, [Employee No_], [Entry No_], [Cause of Absence Code], Description from dbo.[CRONUS Sverige AB$Employee Absence] 
                    union
                    select 'Employee Qualification' as Tabellnamn, [Employee No_], [Line No_], [Qualification Code], Description from dbo.[CRONUS Sverige AB$Employee Qualification] 
                    union
                    select 'Employee Relative' as Tabellnamn, [Employee No_], [Line No_], [Relative Code], [First Name] from dbo.[CRONUS Sverige AB$Employee Relative] 
                    union
                    select 'Employee Portal Setup'as Tabellnamn, [Search Config Table Caption], [Search Limit] , [Config Tool Pane Caption], [Config TP WP Request Caption] from dbo.[CRONUS Sverige AB$Employee Portal Setup] 
                    union
                    select 'Employee Statistics Group' as Tabellnamn, Code, timestamp, Description, ' ' from dbo.[CRONUS Sverige AB$Employee Statistics Group]