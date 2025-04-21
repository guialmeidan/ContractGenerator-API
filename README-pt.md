<p align="right">
  <a href="https://github.com/guialmeidan/apiContratos/blob/master/README.md">
    <img src="https://img.shields.io/badge/ENGLISH-4285F4?style=flat&logo=googletranslate&logoColor=white" alt="Google Translate Badge">
  </a>
</p>

# API - Gerador de Contratos

## Sobre o Projeto

Este repositório contém a API de um sistema desenvolvido durante meu período de voluntariado na [AIESEC no Brasil](https://aiesec.org.br/). A aplicação foi projetada para automatizar a geração de contratos de intercâmbio voluntário, reduzindo erros manuais no preenchimento de dados e garantindo conformidade com as políticas internas da organização — já que falhas na documentação, por vezes, levavam à invalidação dos contratos.

O sistema permite que o usuário insira os dados das partes envolvidas e consulte informações da vaga de intercâmbio por meio de uma API. Com as informações coletadas, o sistema gera automaticamente o contrato e o termo de voluntariado nos formatos .doc (editável) e .pdf.

O projeto foi estruturado em dois componentes principais:

- API de autenticação dos usuários (este repositório);
- [Cliente desktop](https://github.com/guialmeidan/ContractGenerator), responsável pela interface com o usuário, consumo da API e geração dos documentos.

Esta API foi desenvolvida em C#, utilizando o Entity Framework para acesso e persistência de dados.

⚠️ Aviso: Este projeto está obsoleto desde 2018, quando se encerrou minha participação na AIESEC. Além disso, uma das APIs utilizadas para obter os dados das vagas foi descontinuada, comprometendo o funcionamento atual do sistema.

## Funcionalidades da API

- Autenticação de usuário (login)
- Contabilização de contratos gerados (data, usuário e tipo de contrato)

## Arquitetura e Tecnologias

- Linguagem: C#
- ORM: Entity Framework
- Arquitetura: API RESTful com foco em design modular e autenticação

## Status do Projeto

⚠️ **Projeto descontinuado**
Esta API não é mais mantida desde 2018. Algumas dependências externas foram alteradas ou descontinuadas, inviabilizando o funcionamento atual do sistema. Este repositório é mantido como referência histórica e técnica.
