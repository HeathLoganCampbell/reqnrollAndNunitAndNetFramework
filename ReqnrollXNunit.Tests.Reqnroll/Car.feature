Feature: Car
    Scenario: Start the car with enough fuel
        Given the car has sufficient fuel
        When I turn the ignition key
        Then the engine should start

    Scenario: Stop the car with no fuel
        Given the car has insufficient fuel
        When I turn the ignition key
        Then the engine should start
    
        