using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_08 : CardInfo
{
    public CardInfo_048_JA_08()
    {
        this.cardNo = "048_JA_08";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "冷酷なる暴君";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
