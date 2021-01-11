class User {
    private _name: string;
    public age: number;

    get name(): string {
        return this._name;
    }

    set name(newName: string) {
        this._name = newName;
    }

    constructor(_name: string) {
        this.name = _name;
    }

    sayHello(): string {
        return `Hello,${this._name}!`;
    }
}