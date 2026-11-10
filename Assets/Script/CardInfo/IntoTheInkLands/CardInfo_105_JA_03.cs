using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_03 : CardInfo
{
    public CardInfo_105_JA_03()
    {
        this.cardNo = "105_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "剣の達人";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
