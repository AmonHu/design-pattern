export class Singleton {
    name = 'Singleton';

    static instance;

    constructor() {
        if (!Singleton.instance) {
            Singleton.instance = this;
        }
        return Singleton.instance;
    }
}