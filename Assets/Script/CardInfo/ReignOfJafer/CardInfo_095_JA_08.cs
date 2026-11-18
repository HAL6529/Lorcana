using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_08 : CardInfo
{
    public CardInfo_095_JA_08()
    {
        this.cardNo = "095_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ルイス";
        this.cardName2 = "かわいいワニ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
