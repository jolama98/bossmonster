
export class Heroes {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.img = data.img;
    this.damage = data.damage;
    this.health = data.health;
    this.type = data.type;
    this.creatorId = data.creatorId;
  }
  get backgroundImage() {
    return `url(${this.img})`
  }
}

