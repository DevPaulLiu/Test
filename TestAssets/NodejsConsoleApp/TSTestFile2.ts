class Student extends User {
    school: String;
    private _id: number;

    get id(): number {
        return this._id;
    }

    constructor(_name: string, _age: number, _school: string, _id: number) {
        super(_name);
        this.age = _age;
        this.school = _school;
        this._id = _id;
    }

    say() {
        return `Name:${this.name},Age:${this.age},School:${this.school},Id:${this.id}`;
    }

    sayFull() {
        this.sayHello();
        this.say();
    }
}