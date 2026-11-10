using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_04 : CardInfo
{
    public CardInfo_153_JA_04()
    {
        this.cardNo = "153_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "きれい探しの名人";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
