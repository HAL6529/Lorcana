using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_134_JA_13 : CardInfo
{
    public CardInfo_134_JA_13()
    {
        this.cardNo = "134_JA_13";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "Red Moon Ritual";
        this.cardName2 = "赤い月の儀式";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether7 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
