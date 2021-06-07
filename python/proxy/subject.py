class Subject:
    def request(self):
        pass


class RealSubject(Subject):
    def request(self):
        print('Real Subject:this is a request.')


class ProxySubject(Subject):
    real_subject: RealSubject

    def __init__(self, _real_subject: RealSubject):
        self.real_subject = _real_subject

    def request(self):
        print('Proxy Subject:this is a request.')
        self.real_subject.request()
