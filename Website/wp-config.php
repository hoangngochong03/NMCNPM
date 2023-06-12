<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/documentation/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'Boardgame' );

/** Database username */
define( 'DB_USER', 'root' );

/** Database password */
define( 'DB_PASSWORD', '' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'BJ)yw#BY^Wq/KI}z}x}:?*.Yz7Vnz/>[^h)LUp6H>y*bT!]poQw6x:~NfQl[W?pC' );
define( 'SECURE_AUTH_KEY',  'z2Vr2nc d>=cX(@VY*tUfgI4i5g/rSAf`nKvR24!!dLxrm,[>KGBAY,130dwAD}H' );
define( 'LOGGED_IN_KEY',    'q#F%ZF]msK/dvR@8u29&m5[#(x^bY[Yw89oYxDZ(Yhh0bQPHmW14r-zpFe*I?$XU' );
define( 'NONCE_KEY',        '0sG[Hb,%6q;alq{#J:9ZI}_)k7K!&8,=cZRi2Z,8*x6z/Xpz#17pTy%NQV}@(d[z' );
define( 'AUTH_SALT',        '~VC@nf71Tzl&~&)gInjP-R;e{v6oJ${mw(DWxhPZb@a4)0&RnqmRGZ^_0f2|4LAz' );
define( 'SECURE_AUTH_SALT', 'Ykaxl~IsXFMy0UIUCo/RF(I[ #>}XDRRt9KoeIcF:i^v`_.@fT5NyzwIDOFhT*Tk' );
define( 'LOGGED_IN_SALT',   '.<5*HKcZGC `xbaoFz8:[c]6eYa3})Lv`jbaQEf.?b`BPdI$xppG<d3!$oPf9[,b' );
define( 'NONCE_SALT',       'mV t_Fy8MaL-H)]6nu.Yw+q`H|/hoco}mgX4Li0Vs@>J_b}pQgG<vo.|ea{|-3?l' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/documentation/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
