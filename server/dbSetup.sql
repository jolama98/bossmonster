CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) UNIQUE COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';


SELECT * FROM heroes;

INSERT INTO heroes(
  name,
  img,
  type,
  damage,
  health,
  creatorId
)
VALUES(
  "Hulk",
  "https://images-ng.pixai.art/images/orig/4664013c-a0d1-4ed9-a47e-ccc29ab69dea",
"Monster",
"10",
"100",
"6691cd264de80d398f94368a"
);

CREATE TABLE boss(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
img VARCHAR(1000) NOT NULL,
name VARCHAR(255) NOT NULL,
damage INT NOT NULL DEFAULT 50,
health INT NOT NULL DEFAULT 100,
creatorId VARCHAR(255) NOT NULL,
FOREIGN KEY (creatorId) REFERENCES accounts (id) ON DELETE CASCADE
)


SELECT heroes.*, accounts.*
FROM heroes
    JOIN accounts ON accounts.id = heroes.creatorId
WHERE
    heroes.id = @heroesId;