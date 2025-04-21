<p align="right">
  <a href="https://github.com/guialmeidan/apiContratos/blob/master/README-pt.md">
    <img src="https://img.shields.io/badge/PORTUGUESE-4285F4?style=flat&logo=googletranslate&logoColor=white" alt="Google Translate Badge">
  </a>
</p>

# API - Contract Generator

## About the Project

This repository contains the API component of a system developed during my volunteer work at [AIESEC in Brasil](https://aiesec.org.br/). he application was designed to automate the generation of volunteer exchange contracts, reducing human error during data entry and ensuring alignment with the organization's internal compliance policies — since mistakes in documentation sometimes led to the invalidation of contracts.

The system allows users to input the data of all involved parties and retrieve information about exchange opportunities through an API. Once the necessary data is collected, the system generates the contract and the volunteer agreement in both .doc (editable) and .pdf formats.

The project was structured into two main components:

- Authentication API (this repository)
- [Desktop client](https://github.com/guialmeidan/ContractGenerator), responsible for user interaction, API consumption, and contract generation

This API was developed in C#, using Entity Framework for data access and persistence.

⚠️ *Notice**: This project has been deprecated since 2018, following the conclusion of my involvement with AIESEC. Additionally, one of the third-party APIs used to fetch opportunity data was discontinued, impacting the system's current functionality

## API Features

- User authentication (login)
- Tracking of generated contracts, including generation date, user responsible, type of contract

## Architecture and Technologies

- Language: C#
- Architecture: RESTful API with focus on modular design and authentication

## Project Status

⚠️ **Deprecated Project**
This API is no longer maintained as of 2018. External dependencies have changed or been discontinued, preventing the system from operating as intended. This repository is preserved as a historical and technical reference.
