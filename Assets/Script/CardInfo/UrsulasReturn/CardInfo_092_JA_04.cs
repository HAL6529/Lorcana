using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_04 : CardInfo
{
    public CardInfo_092_JA_04()
    {
        this.cardNo = "092_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ゼウス";
        this.cardName2 = "ミスター稲妻";
        this.power = 0;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MoniekSchilder;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
