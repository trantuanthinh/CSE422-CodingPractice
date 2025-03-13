using Lab6.Logger;

Logger logger = new Logger();

logger.Log("User {0} performed action: {1}", "Alice", "Login");
logger.Log("Transaction {0} processed with amount: {1}", 12345, 250.75);
logger.Log("Error at {0}: {1}", DateTime.Now, "Database connection failed");
