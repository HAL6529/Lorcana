using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_04 : CardInfo
{
    public CardInfo_213_JA_04()
    {
        this.cardNo = "213_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "We DonÅft Talk About Bruno";
        this.cardName2 = "îÈñßÇÃÉuÉãÅ[Ém";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VictorYanoCovarrubias;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Enchanted;
    }
}
