import React, { useState } from "react";
import { TextField, Button, Box } from "gestalt";
import GeneratedName from "./GeneratedName";

const validateInputs = (arr: string[]): boolean =>
  arr.every(s => s && s.trim().length > 0);

export default function nameForm() {
  const [state, setState] = useState({} as Names);
  const { first, last, generated } = state;

  const setName = (property: string, value: string) =>
    setState({ ...state, [property]: value });

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    const isValidInput = validateInputs([first, last]);
    setName("generated", isValidInput ? `${first} ${last}` : "");
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <Box margin={2}>
          <TextField
            id="firstName"
            type="text"
            placeholder="First Name"
            value={first || ""}
            onChange={e => setName("first", e.value)}
          />
          <TextField
            id="lastName"
            type="text"
            placeholder="Last Name"
            value={last || ""}
            onChange={e => setName("last", e.value)}
          />
        </Box>
        <Box margin={2}>
          <Button type="submit" text="Generate" />
        </Box>
      </form>
      <GeneratedName name={generated} />
    </div>
  );
}

interface Names {
  first: string;
  last: string;
  generated: string;
}
