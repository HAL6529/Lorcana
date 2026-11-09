using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_02 : CardInfo
{
    public CardInfo_149_JA_02()
    {
        this.cardNo = "149_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヒーラム・フラバーシャム";
        this.cardName2 = "おもちゃ職人";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
