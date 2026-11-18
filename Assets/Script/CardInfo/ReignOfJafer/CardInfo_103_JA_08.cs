using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_08 : CardInfo
{
    public CardInfo_103_JA_08()
    {
        this.cardNo = "103_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヤマネ";
        this.cardName2 = "びっくりネズミ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoelDuQue;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
