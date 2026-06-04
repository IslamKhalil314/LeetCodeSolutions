function isValidSudoku(board: string[][]): boolean {
 let rowSets = Array.from({ length: 9 }, () => new Set<string>());
  let columnSets = Array.from({ length: 9 }, () => new Set<string>());
  let subGridSets = Array.from({ length: 3 }, () =>
    Array.from({ length: 3 }, () => new Set<string>())
  );

  for (let i = 0; i < board.length; i++) {
    for (let j = 0; j < board[i].length; j++) {
      let elm = board[i][j];

      if (elm === ".") continue;
      if (rowSets[i].has(elm)) return false;
      if (columnSets[j].has(elm)) return false;

      let subGrid_i = Math.floor(i / 3);
      let subGrid_j = Math.floor(j / 3);
      if (subGridSets[subGrid_i][subGrid_j].has(elm)) return false;

      rowSets[i].add(elm);
      columnSets[j].add(elm);
      subGridSets[subGrid_i][subGrid_j].add(elm);
    }
  }

  return true;
};
