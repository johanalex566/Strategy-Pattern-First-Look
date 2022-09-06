---------------------------------------------------
The main goals for introducing the strategy pattern
is to make the code more extensible and testable.
---------------------------------------------------


What did we Achieve?

--A more extensible, object oriented and dynamic implementation.

--Easily add new strategies without affecting existing ones.

--Cleaner approach with single responsibility in mind.



Notes:
--The interface defines a contract for each concrete strategy implementation to use.

--When this strategy is applied we can trust that whoever is injecting this implementation into the order
  has made sure it's the appropriate strategy.

--The context should not know about the concrete implementation of a stategy as it will only be using the strategy interface.

--The strategy pattern is a behavioural design pattern and the idea is that you choose suitable strategy based on user input.
