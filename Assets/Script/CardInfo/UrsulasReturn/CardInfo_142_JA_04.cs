using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_04 : CardInfo
{
    public CardInfo_142_JA_04()
    {
        this.cardNo = "142_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ダン・フー";
        this.cardName2 = "タロンの長";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
