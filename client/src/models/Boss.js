export class Boss {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.img = data.img;
    this.damage = data.damage;
    this.health = data.health;
    this.creatorId = data.creatorId;
  }
  get backgroundStyle() {
    return {
      backgroundImage: `url(${this.img})`
    }
  }
}
