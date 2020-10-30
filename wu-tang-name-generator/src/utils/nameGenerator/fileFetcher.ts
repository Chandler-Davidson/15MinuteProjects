import axios from "axios";

export let nouns: string[];
export let adjectives: string[];

async function fetchFiles() {
  nouns = await getTextFile("nouns");
  adjectives = await getTextFile("adjectives");
}

async function getTextFile(filename: string): Promise<string[]> {
  try {
    const resp = await axios.get(`./${filename}.txt`);
    return resp.data.split("\n");
  } catch (error) {}
}

fetchFiles();
