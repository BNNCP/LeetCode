//map reduce filter

type toString = (x: number) => string;
const parseToString: toString = (x) => `"${x}"`;

type Increase = (x: number) => number;
const increaseNum: Increase = (x) => x++;

type IncreaseToString = (x: number) => string;
const increase_to_string: IncreaseToString = (x) => parseToString(increaseNum(x));

type Compose = <A, B, C> (
    f: (x: B) => C,
    g: (x: A) => B) => (x: A) => C
const compose: Compose = (f, g) => x => f(g(x));

const increase_to_string2: IncreaseToString = compose(parseToString, increaseNum);