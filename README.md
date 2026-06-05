# Meta Tracker 🃏

> A meta aggregator for competitive TCGs focused on the Brazilian market.

Tracking the Pokémon TCG meta today means navigating multiple English-language sites, cross-referencing tournament results, and doing all the work yourself. Meta Tracker brings that information together in one place, in Portuguese, built for the Brazilian competitive scene.

Starting with Pokémon TCG — with planned expansion to Magic: The Gathering, One Piece, and others.

---

## Planned Features

- **Deck ranking** styled like a stock market — each deck shows position changes (↑3, ↓1) relative to the previous week
- **Top 50 meta decks** with full decklists
- **Tournament results** with placements and decklists used
- **Brazilian-first** — content and context for the local competitive community
- Future support for Magic: The Gathering, One Piece TCG, and Flesh and Blood

---

## Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core Web API |
| Background jobs | Hangfire |
| Frontend | React + TypeScript |
| Database | PostgreSQL |
| Infrastructure | Docker |
| Data source | [Limitless TCG public API](https://docs.limitlesstcg.com/developer.html) |

---

## Architecture

- [Database model](/docs/architecture/database-model.png)
- [Architecture decisions](/docs/decisions)

---

## How to Run

**Requirements:** Docker installed.

```bash
docker-compose up -d
```

*(full setup instructions coming soon)*

---

## Status

🚧 **In development** — currently in modeling and initial setup phase.

---

## Why This Exists

I play TCGs competitively and got tired of the fragmented experience for Brazilian players. This is a project born from actual frustration with the existing tools — and built with the same stack I use professionally (ASP.NET Core + PostgreSQL), so it's also a sandbox for applying things I learn at work in a context I care about.

---

## Author

[Giovanni Veratacci](https://github.com/nagisavt) — Computer Science student at UTFPR Ponta Grossa & Full Stack Developer
