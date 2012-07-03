import static org.junit.Assert.*;

import org.junit.Test;

public class ListaTest {

	@Test
	public void agregarElementos() {

		List lista = new List();
		assertNotNull(lista.add("hola"));
		assertNotNull(lista.add("mundo"));
	}

	@Test
	public void contarElementos() {

		List lista = new List();
		assertEquals(0, lista.size());

		lista.add("hola");
		assertEquals(1, lista.size());

		lista.add("mundo");
		lista.add("cruel");
		assertEquals(3, lista.size());
	}

	@Test
	public void obtenerValores() {

		List lista = new List();
		String[] vacio = {};

		assertArrayEquals(vacio, lista.values());

		lista.add("hola");
		lista.add("mundo");
		String[] dosValores = { "hola", "mundo" };
		assertArrayEquals(dosValores, lista.values());
	}

	@Test
	public void buscaValores() {

		List lista = new List();

		assertNull(lista.find("hola"));
		lista.add("hola");
		lista.add("mundo");

		assertNotNull(lista.find("hola"));
		assertEquals("mundo", lista.find("mundo").value);
	}

	@Test
	public void borrarElmentos() {

		List lista = new List();
		lista.add("lorem");
		lista.add("ipsum");
		lista.add("dolor");
		lista.add("sit");
		lista.add("amet");

		lista.delete("hola");
		String[] completa = { "lorem", "ipsum", "dolor", "sit", "amet" };
		assertArrayEquals(completa, lista.values());

		lista.delete("lorem");
		String[] sinLorem = { "ipsum", "dolor", "sit", "amet" };
		assertArrayEquals(sinLorem, lista.values());

		lista.delete("amet");
		String[] sinLoremNiAmet = { "ipsum", "dolor", "sit" };
		assertArrayEquals(sinLoremNiAmet, lista.values());

		lista.delete("dolor");
		String[] soloIpsumySit = { "ipsum", "sit" };
		assertArrayEquals(soloIpsumySit, lista.values());
	}
}
