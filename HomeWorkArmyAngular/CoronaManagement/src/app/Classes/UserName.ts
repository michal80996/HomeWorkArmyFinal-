export class UserName {
    constructor(
        public PersonId: string,
        public FullName?: string,
        public City?: string,
        public Street?: string,
        public Phone?: string,
        public BirthDate?:Date,
        public myImage?:string
    ) { }
}

