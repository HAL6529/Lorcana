using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_08 : CardInfo
{
    public CardInfo_143_JA_08()
    {
        this.cardNo = "143_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミスター・スヌープス";
        this.cardName2 = "欺かれた共犯者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
