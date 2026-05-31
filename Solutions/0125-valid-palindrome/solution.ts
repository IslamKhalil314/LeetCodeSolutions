function isPalindrome(str: string): boolean {
      str = str.toLowerCase();
    let left = 0,
    right = str.length - 1;

  while (left < right) {
    while (left < right && !isAlphanumeric(str[left])) {
      left++;
    }
    while (left < right && !isAlphanumeric(str[right])) {
      right--;
    }
    if (str[left] === str[right]) {
      left++;
      right--;
      continue;
    }
    return false;
  }
  return true;
};

function isAlphanumeric(char) {
  return /^[a-z0-9]$/.test(char);
}
