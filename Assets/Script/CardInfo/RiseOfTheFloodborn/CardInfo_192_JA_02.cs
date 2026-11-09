using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_02 : CardInfo
{
    public CardInfo_192_JA_02()
    {
        this.cardNo = "192_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "気まぐれな君主";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
