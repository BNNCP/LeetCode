const fibGenerator = function* (cur = 0, next = 1) {
    yield cur;
    yield* fibGenerator(next, cur + next);
};

const gen = fibGenerator();