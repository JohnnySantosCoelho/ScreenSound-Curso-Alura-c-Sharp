Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Fauline");
ep1.AdicionarConvidados("Johnny");


Episodio ep2 = new(2, "Técnicas de aprendizado", 50);
ep2.AdicionarConvidados("Yasmim");
ep2.AdicionarConvidados("Diego");
ep2.AdicionarConvidados("Veronica");


Podcast podcast = new("Podcast especial", "Daneil");
podcast.AdicionaEpisodio(ep1);
podcast.AdicionaEpisodio(ep2);
podcast.ExibirDetalhes();
