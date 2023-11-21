using Algorithm.Data_Structures.LinkedList;

namespace Algorithm.LinkedList.ReturnKthToLast;

    
    public static class ReturnKthToLast {
        public static T Run<T>(SinglyLinkedList<T> list, int k) {
            if (list.Head == null) {
                throw new Exception("List is empty");
            }

            Node<T> current = list.Head;
            int length = 0;

            while (current != null) {
                length++;
                current = current.Next;
            }

            if (k > length || k <= 0) {
                throw new Exception("Invalid value of k");
            }

            current = list.Head;
            for (int i = 1; i < length - k + 1; i++) {
                current = current.Next;
            }

            return current.Data;
        }
        
        public static T RunWithTwoPointers<T>(SinglyLinkedList<T> list, int k) {
            if (list.Head == null) throw new Exception("List is empty");

            Node<T> pointer1 = list.Head;
            Node<T> pointer2 = list.Head;

            for (int i = 0; i < k; i++) {
                if (pointer2 == null) throw new Exception("K is greater than the length of the list");
                pointer2 = pointer2.Next;
            }

            while (pointer2 != null) {
                pointer1 = pointer1.Next; 
                pointer2 = pointer2.Next;
            }

            return pointer1.Data;
        }
        
        
        //TODO Anlamadım
        public static T RunWithRecursive<T>(SinglyLinkedList<T> list, int k) {
            if (list.Head == null) throw new Exception("List is empty.");

            int idx = 0;
            var result = RecursiveFind(list.Head, k, ref idx);
            if (result == null) throw new Exception($"Element at position {k} from the end does not exist.");

            return result.Data;
        }

        private static Node<T> RecursiveFind<T>(Node<T> node, int k, ref int idx) {
            if (node == null) {
                return null;
            }

            var result = RecursiveFind(node.Next, k, ref idx);
            idx++;

            // When idx reaches k, it means we are at the kth node from the end
            if (idx == k) {
                return node;
            }

            return result;
        }
        
    }
