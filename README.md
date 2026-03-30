# Pokemon Meta Tracker 🃏

> Agregador de meta para TCGs competitivos com foco no público brasileiro.
> Começando pelo Pokémon TCG, com planos de expansão para Magic, One Piece e outros.

## O problema
Para acompanhar o meta do Pokémon TCG hoje, você precisa navegar por vários
sites em inglês. Esse projeto unifica essas informações e as traz para o contexto BR.

## Funcionalidades planejadas
- [ ] Ranking de decks estilo "bolsa de valores" (subiu/desceu X posições)
- [ ] Lista completa dos top 50 decks do meta atual
- [ ] Decklists usadas em torneios com posições
- [ ] Suporte futuro a Magic, One Piece, Flesh and Blood

## Stack
- **Backend:** ASP.NET Core Web API + Hangfire
- **Frontend:** React + TypeScript
- **Banco:** PostgreSQL
- **Infra:** Docker

## Fonte de dados
API pública do [Limitless TCG](https://docs.limitlesstcg.com/developer.html)

## Documentação
- [Modelagem do banco](docs/architecture/database-model.png)
- [Decisões de arquitetura](docs/decisions/)

## Como rodar localmente
```bash
docker-compose up -d
```
*(instruções completas em breve)*

## Status
🚧 Em desenvolvimento — fase de modelagem e setup inicial
