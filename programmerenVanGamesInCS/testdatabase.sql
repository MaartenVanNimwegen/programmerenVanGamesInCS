SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

-- Database: `testdatabase`
CREATE TABLE `scores` (
  `id` int(11) NOT NULL,
  `Naam` varchar(50) DEFAULT NULL,
  `datum` datetime DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  `game` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- Gegevens worden geëxporteerd voor tabel `scores`
INSERT INTO `scores` (`id`, `Naam`, `datum`, `score`, `game`) VALUES
(39, 'Maarten', '2021-11-24 09:37:21', 328, 'FlappyBird'),
(40, 'Maarten', '2021-11-24 09:41:45', 20, 'Lingo'),
(41, 'Arwin', '2021-11-24 09:59:54', 40, 'Lingo'),
(42, 'Rogier', '2021-11-24 16:27:07', 10, 'Lingo'),
(44, 'Martine', '2021-11-24 22:18:29', 14, 'FlappyBird'),
(45, 'Martine', '2021-11-24 22:38:55', 200, 'Lingo'),
(46, 'Arwin', '2021-11-25 12:32:16', 54, 'FlappyBird');

-- --------------------------------------------------------

-- Tabelstructuur voor tabel `words`
CREATE TABLE `words` (
  `id` int(11) NOT NULL,
  `word` varchar(5) NOT NULL,
  `language` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=UTF8MB4;

-- Gegevens worden geëxporteerd voor tabel `words`
INSERT INTO `words` (`id`, `word`, `language`) VALUES
(378, 'babes', 'en'),
(379, 'cabin', 'en'),
(380, 'cable', 'en'),
(381, 'daddy', 'en'),
(382, 'eager', 'en'),
(383, 'eagle', 'en'),
(384, 'early', 'en'),
(385, 'faces', 'en'),
(386, 'faced', 'en'),
(387, 'gaged', 'en'),
(388, 'habit', 'en'),
(389, 'hacks', 'en'),
(390, 'horny', 'en'),
(391, 'horns', 'en'),
(392, 'label', 'en'),
(393, 'labor', 'en'),
(394, 'rabid', 'en'),
(395, 'saber', 'en'),
(396, 'utter', 'en'),
(397, 'vague', 'en'),
(398, 'wacky', 'en'),
(399, 'wacks', 'en'),
(400, 'xenon', 'en'),
(401, 'yacht', 'en'),
(402, 'accus', 'nl'),
(403, 'appel', 'nl'),
(404, 'aarde', 'nl'),
(405, 'apart', 'nl'),
(406, 'airco', 'nl'),
(407, 'akker', 'nl'),
(408, 'afzag', 'nl'),
(409, 'babys', 'nl'),
(410, 'blijf', 'nl'),
(411, 'boten', 'nl'),
(412, 'boren', 'nl'),
(413, 'broek', 'nl'),
(414, 'beeld', 'nl'),
(415, 'blauw', 'nl'),
(416, 'bloed', 'nl'),
(417, 'bezig', 'nl'),
(418, 'chips', 'nl'),
(419, 'draai', 'nl'),
(420, 'delen', 'nl'),
(421, 'dwaas', 'nl'),
(422, 'droog', 'nl'),
(423, 'dwaal', 'nl'),
(424, 'daten', 'nl'),
(425, 'dozen', 'nl'),
(426, 'debat', 'nl'),
(427, 'derde', 'nl'),
(428, 'drank', 'nl'),
(429, 'elder', 'nl'),
(430, 'echte', 'nl'),
(431, 'enkel', 'nl'),
(432, 'enorm', 'nl'),
(433, 'eisen', 'nl'),
(434, 'fiets', 'nl'),
(435, 'films', 'nl'),
(436, 'feest', 'nl'),
(437, 'falen', 'nl'),
(438, 'geven', 'nl'),
(439, 'getal', 'nl'),
(440, 'groet', 'nl'),
(441, 'gemak', 'nl'),
(442, 'goede', 'nl'),
(443, 'gezin', 'nl'),
(444, 'horen', 'nl'),
(445, 'heren', 'nl'),
(446, 'helft', 'nl'),
(447, 'hemel', 'nl'),
(448, 'haast', 'nl'),
(449, 'hangt', 'nl'),
(450, 'hobby', 'nl'),
(451, 'hamer', 'nl'),
(452, 'ieder', 'nl'),
(453, 'immer', 'nl'),
(454, 'icoon', 'nl'),
(455, 'jaren', 'nl'),
(456, 'juist', 'nl'),
(457, 'koken', 'nl'),
(458, 'kegel', 'nl'),
(459, 'kubus', 'nl'),
(460, 'klein', 'nl'),
(461, 'kreeg', 'nl'),
(462, 'klant', 'nl'),
(463, 'komst', 'nl'),
(464, 'kapot', 'nl'),
(465, 'kookt', 'nl'),
(466, 'kroeg', 'nl'),
(467, 'keren', 'nl'),
(468, 'koker', 'nl'),
(469, 'kabel', 'nl'),
(470, 'koers', 'nl'),
(471, 'kerst', 'nl'),
(472, 'kopen', 'nl'),
(473, 'komen', 'nl'),
(474, 'lopen', 'nl'),
(475, 'links', 'nl'),
(476, 'lucht', 'nl'),
(477, 'leger', 'nl'),
(478, 'later', 'nl'),
(479, 'lonen', 'nl'),
(480, 'lenen', 'nl'),
(481, 'laden', 'nl'),
(482, 'lever', 'nl'),
(483, 'leren', 'nl'),
(484, 'lukte', 'nl'),
(485, 'laars', 'nl'),
(486, 'losse', 'nl'),
(487, 'leest', 'nl'),
(488, 'loont', 'nl'),
(489, 'leven', 'nl'),
(490, 'lingo', 'nl'),
(491, 'leeft', 'nl'),
(492, 'leert', 'nl'),
(493, 'lepel', 'nl'),
(494, 'lezen', 'nl'),
(495, 'loopt', 'nl'),
(496, 'koopt', 'nl'),
(497, 'lager', 'nl'),
(498, 'leuke', 'nl'),
(499, 'lieve', 'nl'),
(500, 'maand', 'nl'),
(501, 'mooie', 'nl'),
(502, 'musea', 'nl'),
(503, 'menig', 'nl'),
(504, 'motie', 'nl'),
(505, 'malen', 'nl'),
(506, 'motor', 'nl'),
(507, 'molen', 'nl'),
(508, 'mogen', 'nl'),
(509, 'muren', 'nl'),
(510, 'modus', 'nl'),
(511, 'maken', 'nl'),
(512, 'maten', 'nl'),
(513, 'mogen', 'nl'),
(514, 'markt', 'nl'),
(515, 'meren', 'nl'),
(516, 'mertk', 'nl'),
(517, 'meten', 'nl'),
(518, 'onder', 'nl'),
(519, 'onwel', 'nl'),
(520, 'omdat', 'nl'),
(521, 'opzet', 'nl'),
(522, 'ofwel', 'nl'),
(523, 'optie', 'nl'),
(524, 'oogst', 'nl'),
(525, 'ouder', 'nl'),
(526, 'onzin', 'nl'),
(527, 'ovaal', 'nl'),
(528, 'oogje', 'nl'),
(529, 'omzet', 'nl'),
(530, 'onder', 'nl'),
(531, 'oprit', 'nl'),
(532, 'palen', 'nl'),
(533, 'piano', 'nl'),
(534, 'pauze', 'nl'),
(535, 'praat', 'nl'),
(536, 'prima', 'nl'),
(537, 'paren', 'nl'),
(538, 'pakte', 'nl'),
(539, 'plein', 'nl'),
(540, 'poten', 'nl'),
(541, 'pasen', 'nl'),
(542, 'plukt', 'nl'),
(543, 'pegel', 'nl'),
(544, 'paden', 'nl'),
(545, 'paard', 'nl'),
(546, 'paars', 'nl'),
(547, 'poort', 'nl'),
(548, 'quota', 'nl'),
(549, 'robot', 'nl'),
(550, 'regen', 'nl'),
(551, 'rugby', 'nl'),
(552, 'ruist', 'nl'),
(553, 'radar', 'nl'),
(554, 'ronde', 'nl'),
(555, 'recht', 'nl'),
(556, 'raakt', 'nl'),
(557, 'radio', 'nl'),
(558, 'reden', 'nl'),
(559, 'regel', 'nl'),
(560, 'recht', 'nl'),
(561, 'regie', 'nl'),
(562, 'ritje', 'nl'),
(563, 'reken', 'nl'),
(564, 'rente', 'nl'),
(565, 'roken', 'nl'),
(566, 'racen', 'nl'),
(567, 'raken', 'nl'),
(568, 'raden', 'nl'),
(569, 'regio', 'nl'),
(570, 'staan', 'nl'),
(571, 'stoel', 'nl'),
(572, 'stoep', 'nl'),
(573, 'sport', 'nl'),
(574, 'staat', 'nl'),
(575, 'straf', 'nl'),
(576, 'stond', 'nl'),
(577, 'stuur', 'nl'),
(578, 'schok', 'nl'),
(579, 'staal', 'nl'),
(580, 'steek', 'nl'),
(581, 'stook', 'nl'),
(582, 'spalk', 'nl'),
(583, 'steun', 'nl'),
(584, 'stapt', 'nl'),
(585, 'sfeer', 'nl'),
(586, 'slaap', 'nl'),
(587, 'speel', 'nl'),
(588, 'samen', 'nl'),
(589, 'sjaal', 'nl'),
(590, 'strak', 'nl'),
(591, 'snoep', 'nl'),
(592, 'sloot', 'nl'),
(593, 'soort', 'nl'),
(594, 'stoom', 'nl'),
(595, 'steeg', 'nl'),
(596, 'schep', 'nl'),
(597, 'storm', 'nl'),
(598, 'spoor', 'nl'),
(599, 'soort', 'nl'),
(600, 'start', 'nl'),
(601, 'slaan', 'nl'),
(602, 'stopt', 'nl'),
(603, 'truck', 'nl'),
(604, 'talen', 'nl'),
(605, 'tafel', 'nl'),
(606, 'taken', 'nl'),
(607, 'thuis', 'nl'),
(608, 'tekst', 'nl'),
(609, 'trouw', 'nl'),
(610, 'thema', 'nl'),
(611, 'tegen', 'nl'),
(612, 'terug', 'nl'),
(613, 'tegel', 'nl'),
(614, 'teken', 'nl'),
(615, 'tegen', 'nl'),
(616, 'teken', 'nl'),
(617, 'trekt', 'nl'),
(618, 'trein', 'nl'),
(619, 'trucs', 'nl'),
(620, 'treft', 'nl'),
(621, 'typen', 'nl'),
(622, 'taart', 'nl'),
(623, 'titel', 'nl'),
(624, 'tegen', 'nl'),
(625, 'tonen', 'nl'),
(626, 'tempo', 'nl'),
(627, 'tocht', 'nl'),
(628, 'telde', 'nl'),
(629, 'velen', 'nl'),
(630, 'varen', 'nl'),
(631, 'vaten', 'nl'),
(632, 'vogel', 'nl'),
(633, 'volgt', 'nl'),
(634, 'vaker', 'nl'),
(635, 'vaart', 'nl'),
(636, 'vecht', 'nl'),
(637, 'vindt', 'nl'),
(638, 'vloot', 'nl'),
(639, 'verte', 'nl'),
(640, 'vegen', 'nl'),
(641, 'vuren', 'nl'),
(642, 'vorig', 'nl'),
(643, 'vraag', 'nl'),
(644, 'vulde', 'nl'),
(645, 'villa', 'nl'),
(646, 'virus', 'nl'),
(647, 'vloog', 'nl'),
(648, 'vormt', 'nl'),
(649, 'vloer', 'nl'),
(650, 'veren', 'nl'),
(651, 'vrouw', 'nl'),
(652, 'vezel', 'nl'),
(653, 'vanaf', 'nl'),
(654, 'voelt', 'nl'),
(655, 'vaste', 'nl'),
(656, 'voert', 'nl'),
(657, 'vette', 'nl'),
(658, 'vuile', 'nl'),
(659, 'video', 'nl'),
(660, 'vader', 'nl'),
(661, 'vlees', 'nl'),
(662, 'vries', 'nl'),
(663, 'volle', 'nl'),
(664, 'voedt', 'nl'),
(665, 'verre', 'nl'),
(666, 'vrede', 'nl'),
(667, 'woord', 'nl'),
(668, 'warme', 'nl'),
(669, 'wazig', 'nl'),
(670, 'winst', 'nl'),
(671, 'werkt', 'nl'),
(672, 'weken', 'nl'),
(673, 'woede', 'nl'),
(674, 'wagen', 'nl'),
(675, 'weten', 'nl'),
(676, 'wegen', 'nl'),
(677, 'weken', 'nl'),
(678, 'water', 'nl'),
(679, 'woont', 'nl'),
(680, 'witte', 'nl'),
(681, 'wonen', 'nl'),
(682, 'weven', 'nl'),
(683, 'wordt', 'nl'),
(684, 'wacht', 'nl'),
(685, 'waren', 'nl'),
(686, 'weren', 'nl'),
(687, 'waard', 'nl'),
(688, 'wilde', 'nl'),
(689, 'welke', 'nl'),
(690, 'xenon', 'nl'),
(691, 'yacht', 'nl'),
(692, 'zwaar', 'nl'),
(693, 'zeven', 'nl'),
(694, 'zaken', 'nl'),
(695, 'zulke', 'nl'),
(696, 'zowel', 'nl'),
(697, 'zeker', 'nl'),
(698, 'zette', 'nl'),
(699, 'zoals', 'nl'),
(700, 'zware', 'nl'),
(701, 'zomer', 'nl'),
(702, 'zicht', 'nl'),
(703, 'zeker', 'nl'),
(704, 'zonde', 'nl'),
(705, 'zover', 'nl'),
(706, 'zodra', 'nl'),
(707, 'zalen', 'nl'),
(708, 'zowat', 'nl'),
(709, 'zesde', 'nl'),
(710, 'zeden', 'nl'),
(711, 'zadel', 'nl'),
(712, 'zaten', 'nl'),
(713, 'zorgt', 'nl'),
(714, 'zelfs', 'nl'),
(715, 'zoals', 'nl'),
(716, 'zocht', 'nl'),
(717, 'zagen', 'nl'),
(718, 'zwart', 'nl'),
(719, 'zoals', 'nl'),
(720, 'zelfs', 'nl'),
(721, 'zover', 'nl'),
(722, 'zwemt', 'nl');

--
-- Indexen voor geëxporteerde tabellen
--
ALTER TABLE `scores`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `words`
--
ALTER TABLE `words`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen

-- AUTO_INCREMENT voor een tabel `scores`
ALTER TABLE `scores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT voor een tabel `words`
ALTER TABLE `words`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=723;
COMMIT;

