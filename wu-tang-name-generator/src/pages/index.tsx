import React from "react";
import Head from "next/head";
import { Heading, Box } from "gestalt";
import "gestalt/dist/gestalt.css";

import NameForm from "../components/NameForm";

const Index = () => (
  <div>
    <Head>
      <title>Wu-Tang Name Generator</title>
    </Head>

    <Box display="flex" direction="column" justifyContent="center">
      <Box display="flex" direction="row" justifyContent="center">
        <Heading color="white">Wu-Tang Name Generator</Heading>
      </Box>
      <NameForm />
    </Box>

    <style jsx global>
      {`
        body {
          background-color: #4d5061;
        }
      `}
    </style>
  </div>
);

export default Index;
