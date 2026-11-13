using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_07 : CardInfo
{
    public CardInfo_160_JA_07()
    {
        this.cardNo = "160_JA_07";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉâÉbÉLÅ[";
        this.cardName2 = "Ç¢ÇøÇŒÇÒÇÃÇøÇ—ÇøÇ·ÇÒ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
