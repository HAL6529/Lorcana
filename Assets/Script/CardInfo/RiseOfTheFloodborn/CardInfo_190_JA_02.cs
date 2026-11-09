using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_02 : CardInfo
{
    public CardInfo_190_JA_02()
    {
        this.cardNo = "190_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ƒpƒ`ƒƒ";
        this.cardName2 = "‘º‚ÌŽw“±ŽÒ";
        this.power = 4;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
