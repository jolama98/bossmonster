import { DatabaseItem } from "./DatabaseItem.js"

export class Heroes extends DatabaseItem {
  constructor(data) {
    super(data);
    this.name = data.name;
    this.img = data.img;
    this.damage = data.damage;
    this.health = data.health;
    this.type = data.type;
    this.creatorId = data.creatorId;
  }
}

