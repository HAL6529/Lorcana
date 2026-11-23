using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_11 : CardInfo
{
    public CardInfo_010_JA_11()
    {
        this.cardNo = "010_JA_11";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ファングマイヤー";
        this.cardName2 = "クールな警官";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
