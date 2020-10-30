import { nouns, adjectives } from "./fileFetcher";

export default function generateWutangName(name: string): string {
  const hash = generateHash(name);

  const files = [adjectives, nouns];
  const norms = files.map(f => hash % f.length);
  const names = norms.map((n, i) => files[i][n]);
  return names.join(" ");
}

function generateHash(str: string): number {
  // https://stackoverflow.com/a/7616484
  const charCodes = str
    .toUpperCase()
    .split("")
    .map(c => c.charCodeAt(0));

  const hash = charCodes.reduce(
    (hash: number, charCode: number) => ((hash << 5) - hash + charCode) | 0,
    0
  );

  return Math.abs(hash);
}
