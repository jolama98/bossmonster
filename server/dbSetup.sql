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
  "Aragorn",
  "https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F5725f8b4-2d9e-4ef8-b0c1-328e99ca0987_720x405.webp
",
"Ranger",
"10",
"100",
"6691cd264de80d398f94368a"
);