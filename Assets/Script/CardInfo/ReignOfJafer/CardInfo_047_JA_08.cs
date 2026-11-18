using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_08 : CardInfo
{
    public CardInfo_047_JA_08()
    {
        this.cardNo = "047_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マダム・メデューサ";
        this.cardName2 = "欺く共犯者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
