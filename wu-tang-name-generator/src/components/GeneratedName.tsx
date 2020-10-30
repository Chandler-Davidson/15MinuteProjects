import { useState, useEffect } from "react";
import generateWutangName from "../utils/nameGenerator/nameGenerator";
import { Heading, Box } from "gestalt";

export default function generatedName({ name }) {
  const [wuName, setWuName] = useState("");

  useEffect(() => {
    setWuName(name ? generateWutangName(name) : "");
  }, [name]);

  return (
    <Box display="flex" direction="row" justifyContent="center">
      <Heading color="white">{wuName}</Heading>
    </Box>
  );
}
