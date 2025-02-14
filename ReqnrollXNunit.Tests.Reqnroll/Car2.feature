Feature: Car2
    Scenario: Start the car with enough fuel2
        Given the car has sufficient fuel
        When I turn the ignition key
        Then the engine should start

    Scenario: Stop the car with no fuel2
        Given the car has insufficient fuel
        When I turn the ignition key
        Then the engine should start
    
        