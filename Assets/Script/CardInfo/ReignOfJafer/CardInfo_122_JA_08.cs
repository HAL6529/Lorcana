using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_08 : CardInfo
{
    public CardInfo_122_JA_08()
    {
        this.cardNo = "122_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "正直ジョン";
        this.cardName2 = "恥知らずのペテン師";
        this.power = 7;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
