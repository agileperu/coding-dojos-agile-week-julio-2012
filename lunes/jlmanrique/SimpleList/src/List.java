public class List {

	private Node first;

	public Node add(String value) {

		Node node = new Node(value);
		if (first == null) {
			first = node;
		} else {
			Node last = first;
			Node next = first.next;
			while (next != null) {
				last = next;
				next = next.next;
			}
			last.next = node;
		}
		return node;
	}

	public int size() {

		Node last = first;
		int size = 0;
		while (last != null) {
			last = last.next;
			size++;
		}
		return size;
	}

	public String[] values() {

		String[] values = new String[size()];
		Node actual = first;
		int index = 0;
		while (actual != null) {
			values[index] = actual.value;
			actual = actual.next;
			index++;
		}
		return values;
	}

	public Node find(String value) {

		Node node = null;
		Node actual = first;
		while (node == null && actual != null) {
			if (value.equals(actual.value)) {
				node = actual;
			} else {
				actual = actual.next;
			}
		}
		return node;
	}

	public void delete(String value) {

		Node actual = first;
		if (actual != null) {
			if (actual.value.equals(value)) {
				first = actual.next;
			} else {
				boolean found = false;
				Node previous = actual;
				actual = actual.next;
				while (!found && actual != null) {
					found = actual.value.equals(value);
					if (found) {
						if (actual.next == null) {
							previous.next = null;
						} else {
							previous.next = actual.next;
						}
					} else {
						previous = actual;
						actual = actual.next;
					}
				}
			}
		}
	}
}
